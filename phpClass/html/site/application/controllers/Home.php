<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Home extends CI_Controller {

	/**
	 * Index Page for this controller.
	 *
	 * Maps to the following URL
	 * 		http://example.com/index.php/welcome
	 *	- or -
	 * 		http://example.com/index.php/welcome/index
	 *	- or -
	 * Since this controller is set as the default controller in
	 * config/routes.php, it's displayed at http://example.com/
	 *
	 * So any other public methods not prefixed with an underscore will
	 * map to /index.php/welcome/<method_name>
	 * @see https://codeigniter.com/user_guide/general/urls.html
	 */
	public function index()
	{
        //Load the form helper.
        $this->load->helper('form');

		$this->load->view('public/home');
	}

	public function login()
    {//Load in validation.
        $this->load->library('form_validation');
        //Pass name, user facing name, validation rules.
        $this->form_validation->set_rules('user_name', 'User Name', 'required|trim|valid_email');
        $this->form_validation->set_rules('user_password', 'Password', 'required|trim');

        if($this->form_validation->run() == false)
        {//Send the user back to the logic screen, and populate some errors.
            $data = ['load_error' => true];
            $this->load->view('public/home', $data);
        }
        else
        {//Check database for valid user with name/password.
            //Load the model.
            $this->load->model('Member');

            if($this->Member->user_login($this->input->post('user_name'), $this->input->post('user_password')))
            {
                $this->load->view('admin/home');
            }
            else
            {
                //Bad password.
                $data = ['load_error' => true,
                    'error_message' => 'Invalid Username or Password!'];
                $this->load->view('public/home', $data);
            }


        }

        //echo $this->form_validation->run(); exit();
    }

    public function create()
    {
        //After the user is created after clicking submit, create something to notify the user.
        //Email must be valid, name is required.
        //Password and confirm password must match.

        //Load in form validation.
        $this->load->library('form_validation');
        //Validate
        $this->form_validation->set_rules('new_user_name', 'User Name', 'required|trim|valid_email');
        $this->form_validation->set_rules('new_full_name', 'FullName', 'required|trim');
        $this->form_validation->set_rules('new_user_password', 'Password', 'required|trim');
        $this->form_validation->set_rules('confirm_password', 'Password Confirmation', 'required|trim|matches[new_user_password]');


        if($this->form_validation->run() == false)
        {
            $data = ['load_error' => true];
            $this->load->view('public/home', $data);
        }
        else
        {
            $this->load->model('Member');

            //Check to see if the account has been made.
            if($this->Member->create_user($this->input->post('new_user_name'), $this->input->post('new_full_name'), $this->input->post('new_user_password')))
            {
                //Send the user back after account creation.
                $data = ['account_made' => true, 'confirmation_message' => 'Your account has been registered.'];
                $this->load->view('public/home', $data);
            }
            else
            {
                //Account could not be made.
                $data = ['load_error' => true,
                    'error_message' => 'Account could not be made.'];
                $this->load->view('public/home', $data);
            }
        }
    }
}
