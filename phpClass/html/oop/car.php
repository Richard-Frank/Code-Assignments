<?php

    class Car
    {
        /** color
         * @var string
         */
        private $color;
        /** make
         * @var string
         */
        public $make;
        /** make
         * i.e. Chevy, Ford, etc.
         *
         * @var string
         */
        public $model;
        /** model
         * i.e. Corvette, Viper, Mustang, etc.
         *
         * @var string
         */
        public $year;
        /** year
         * @var int
         */
        public $status;
        /** status
         * Parketed, forward, reverse, etc.
         * @var string
         */

        /**
         * Car constructor.
         */
        function __construct()
        {//constructors use double _ because reasons.
            $this->status = "Parked";
        }

        /**
         * Put the car in drive.
         */
        function drive()
        {
            echo "The car is moving forwards. <br />";
            $this->status = "Drive";
        }

        /**
         * Put the car in reverse.
         */
        function reverse()
        {
            echo "The car is moving backwards <br />";
            $this->status = "Reverse";
        }

        /**
         * Put the car in park.
         */
        function park()
        {
            echo "The car is now parked. <br />";
            $this->status = "Parked";
        }

        /**
         * Checks the color against the database of valid colors. If it is on the list, sets the car's color.
         * @param $color - The color of the car.
         */
        function setColor($color)
        {
            $valid_colors = ['red','blue','green','black','white','orange','aqua'];

            if(!in_array(strtolower($color), $valid_colors))
            {
                echo "That is an invalid color.";
            }
            else{$this->$color;}

        }

        /**
         * Returns the car's color.
         */
        function getColor()
        {
            return $this->color;
        }
    }//End of Car Class

    try
    {
        //Error catching.
        //echo $this->BadMethod;

        $my_first_car = new Car();

        $my_first_car->setColor("Green");
        $my_first_car->make = "Dodge";
        $my_first_car->model = "Shadow";
        $my_first_car->year = 1994;

        echo "My first car was a $my_first_car->year $my_first_car->getColor $my_first_car->make $my_first_car->model <br/>";
        echo "<br />";

        //""Drive the car""
        $my_first_car->drive();
        $my_first_car->reverse();
        $my_first_car->park();
    } catch(Exception $e)
    {
        echo $e->getMessage();
    }


?>