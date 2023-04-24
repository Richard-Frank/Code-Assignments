<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Member extends CI_Model {


    public function user_login($user_email, $user_password)
    {
        //Load the database
        $this->load->database();
        //Load the session
        $this->load->library('session');

        try
        {
            $db = new PDO($this->db->dsn, $this->db->username, $this->db->password, $this->db->options);
            $sql = $db->prepare("
            SELECT
            password, role_id, member_key
            FROM 
            phpclass.member_login
            WHERE
            email = :Email
        ");
            $sql->bindValue(':Email', $user_email);
            $sql->execute();

            $row = $sql->fetch();

            if($row !== false)
            {//Validate the password
                $hashed_password = md5($user_password.$row['member_key']);

                if($hashed_password == $row['password'])
                {//Checks the input against the hashed password.

                    $this->session->set_userdata(['UID' => $row['member_key']]);

                    return true;
                    //$_SESSION['UID'] = $row['member_key'];
                    //$_SESSION['ROLE'] = $row['role_id'];
                }
                else
                {//Invalid password.
                    return false;
                }

            }
            else
            {//Invalid email.
                return false;
            }


        }catch(PDOException $e){return false;}
    }

    public function create_user($email, $fullname, $password)
    {
        //Load the database
        $this->load->database();
        //Load the session
        $this->load->library('session');

        try
        {
            //Check for duplicate emails.
            $db = new PDO($this->db->dsn, $this->db->username, $this->db->password, $this->db->options);
            $sql = $db->prepare("
                SELECT member_id FROM phpclass.member_login WHERE email = :Email  
            ");
            $sql->bindValue(':Email', $email);
            $sql->execute();
            $row = $sql->fetch();

            if($row != false)
            {//Duplicate found.
                return false;
            }
        }catch(PDOException $e){ return false;}
            try {

                ////////////
                //Hard coded GUID generation
                $member_key = sprintf('%04X%04X%04X%04X%04X%04X%04X%04X',
                    mt_rand(0, 65535),
                    mt_rand(0, 65535),
                    mt_rand(0, 65535),
                    mt_rand(16384, 20479),
                    mt_rand(32768, 49151),
                    mt_rand(0, 65535),
                    mt_rand(0, 65535),
                    mt_rand(0, 65535));
                /////////////

                //Prepare the SQL
                $sql = $db->prepare("
                INSERT INTO phpclass.member_login
                (name, email, role_id, password, member_key)
                 VALUE (:MemberName, :Email, :RoleID, :Password, :MemberKey)
            ");
                $sql->bindValue(':MemberName', $fullname);
                $sql->bindValue(':Email', $email);
                $sql->bindValue('RoleID', 1);
                $sql->bindValue(':Password', md5($password . $member_key));
                $sql->bindValue(':MemberKey', $member_key);

                $sql->execute();
                return true;

            } catch (PDOException $e) {
                return false;
            }
    }
}
