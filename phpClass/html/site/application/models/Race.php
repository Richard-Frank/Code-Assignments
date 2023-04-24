<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Race extends CI_Model {



    public function get_races()
    {
        $this->load->database();

        try
        {
            //Select * from races
            $query = $this->db->get('races');

            //Return the result as an array
            return $query->result_array();

        }catch(PDOException $e) {echo $e->getMessage(); exit();}
    }

    /**
     *Get race database record.
     *
     * @param int $race_id | Primary key of the race
     * @return mixed
     */
    public function get_race($race_id)
    {
        $this->load->database();

        try
        {
            $data = ['race_id'=> $race_id];

            //Select from races WHERE
            $query = $this->db->get_where('races', $data);

            //Return the result as an array
            return $query->result_array();

        }catch(PDOException $e) {echo $e->getMessage(); exit();}
    }

    /**
     * Add a race to the database
     *
     * @param string $race_name
     * @param string $race_location
     * @param string $race_description
     * @param DateTime $race_date | The Date & Time of a race in military time. (Format: YYYY-MM-DD HH-MM)
     */
    public function add_race($race_name, $race_location, $race_description, $race_date)
    {
        $this->load->database();

        try
        {

            $data = [
                'race_name' => $race_name,
                'race_location' => $race_location,
                'race_description' => $race_description,
                'race_date_time' => $race_date
            ];

            $query = $this->db->insert('races', $data);

        }catch (PDOException $e) {$e->getMessage(); exit();}
    }

    /**
     * Remove a race event record from the 'races' database.
     *
     * @param int $race_id | Primary key of the race we want to delete.
     */
    public function delete_race($race_id)
    {
        //echo $race_id; exit();
        $this->load->database();

        try
        {
            $data = ['race_id' => $race_id];

            $query = $this->db->delete('races', $data);

        }catch(Exception $e) {$e->getMessage(); exit();}
    }

    /**
     * Update race event in the database.
     *
     * @param int $race_id | primary key of record you want to update.
     * @param string $race_name
     * @param string $race_location
     * @param string $race_description
     * @param DateTime $race_date | The Date & Time of a race in military time. (Format: YYYY-MM-DD HH-MM)
     */
    public function update_race($race_id, $race_name, $race_location, $race_description, $race_date)
    {
        $this->load->database();

        try
        {
            $data = [
                'race_name'=>$race_name,
                'race_location'=>$race_location,
                'race_description'=>$race_description,
                'race_date_time'=>$race_date
            ];
            $this->db->where('race_id', $race_id);

            $query = $this->db->update('races', $data);
            //print_r($query); exit();

        }catch(PDOException $e) {$e->getMessage(); exit();}
    }

    /*try
        {


        }catch(PDOException $e) {$e->getMessage(); exit();} */


}
