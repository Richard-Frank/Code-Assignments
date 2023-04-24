<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Admin extends CI_Controller {

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
        //$this->load->library('session');
        //echo $this->session->get_userdata("UID"); exit();

        $data = ['dashboard'=> true];

		$this->load->view('admin/dashboard', $data);
	}

	public function manage_marathons()
    {
        $this->load->model('Race');


        $data = ['manage_marathons' => true,
                 'races' => $this->Race->get_races()];

        $this->load->view('admin/manage_marathons', $data);
    }

    public function add_race()
    {//This function handles the form submission from the add_marathon page.

        $this->load->model('Race');

        $this->Race->add_race
        (//This contains no data validation.

            $this->input->post('txt_name'),
            $this->input->post('txt_location'),
            $this->input->post('txt_description'),
            $this->input->post('txt_date')
        );

        //Redirects with a refresh method.
        redirect("admin/manage_marathons", "refresh");

    }

    public function add_marathon()
    {//Form view

        $data = ['add_marathon'=> true];


        $this->load->view('admin/add_marathon', $data);
    }

    public function manage_runners()
    {

        $data = ['manage_runners'=> true];
        $this->load->view('admin/manage_runners', $data);
    }

    public function registration_form()
    {
        $data = ['registration_form'=> true];

        $this->load->view('admin/registration_form', $data);
    }

    public function delete_race($race_id)
    {
        $this->load->model('Race');

        $this->Race->delete_race($race_id);

        redirect("admin/manage_marathons", "refresh");
    }

    public function update_race($race_id)
    {//Form View
        $this->load->model('Race');
        $race = $this->Race->get_race($race_id);

        $data = ['race'=>$race];

        $this->load->view('admin/update_marathon', $data);
    }

    public function edit_race()
    {//This function handles the submission from the update_race page.

        $this->load->model('Race');

        $this->Race->update_race(

            $this->input->post('txt_id'),
            $this->input->post('txt_name'),
            $this->input->post('txt_location'),
            $this->input->post('txt_description'),
            $this->input->post('txt_date')

        );

        redirect("admin/manage_marathons", "refresh");
    }



	/*
	//Template pages.
	public function view_one()
    {
        $this->load->view('admin/1');
    }
    public function view_two()
    {
        $this->load->view('admin/2');
    }
    public function view_three()
    {
        $this->load->view('admin/3');
    }
    public function view_four()
    {
        $this->load->view('admin/4');
    }
    public function view_five()
    {
        $this->load->view('admin/5');
    }
    public function view_six()
    {
        $this->load->view('admin/6');
    }
    public function view_seven()
    {
        $this->load->view('admin/7');
    }
	*/
}
