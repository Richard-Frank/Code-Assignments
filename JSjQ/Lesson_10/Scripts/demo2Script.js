$(function() { 
    console.log("Script Loaded");
    let running = false;

    //Object
    function Vehicle(make, model, color, year, picture)
    {
        this.make = make;
        this.model = model;
        this.color = color;
        this.year =  year;
        this.picture = picture;

    }

    //List of objects.
    let VehicleList = [

        new Vehicle('Ford','Focus', 'Yellow', '2017', 'https://www.focusmania.com/wp-content/uploads/2017/04/2017-Ford-Focus-ST-Triple-Yellow.gif'),

        new Vehicle("Ford", "Explorer", "White", "2017", "https://www.cstatic-images.com/car-pictures/xl/USC60FOS102E021001.png"),

        new Vehicle("Honda", "Pilot", "Red", "2003", "http://st.motortrend.com/uploads/sites/10/2015/11/2003-honda-pilot-ex-suv-angular-front.png"),

        new Vehicle("Honda", "CRV", "Gray", "2015", "https://media.ed.edmunds-media.com/honda/cr-v/2015/oem/2015_honda_cr-v_4dr-suv_touring_fq_oem_3_1280.jpg"),

        new Vehicle("Chevrolet", "Cruze", "Black", "2015", "https://www.sunnysideauto.com/assets/stock/colormatched_01/white/640/cc_2016che022c_01_640/cc_2016che022c_01_640_gar.jpg")

    ]

    function ShowCars(start = 0, make = null, year = null)
    {
        $('#btnList').css("pointer-events", "none");

        if(start < VehicleList.length)
        {     
            if((make == null || make == VehicleList[start].make) && (year == null || year == VehicleList[start].year))
            {
                $("<img>").attr('src',VehicleList[start].picture).appendTo('#car').hide().fadeIn("slow").delay("1000").
                fadeOut("Slow", function(){ $('#car').empty(); start++; ShowCars(start, make, year); });
            }
            else
            {
                start++; ShowCars(start, make, year);
            }
        }
        else
        {
            $("<img>").attr('src','https://media5.picsearch.com/is?JVqGTLOatizmlsiCBoDwsUFIDmgy_qvQG8SrADGUoE0&height=236').appendTo('#car').hide().fadeIn("Slow")
            .delay("1000").fadeOut("Slow", function(){ $('#car').empty(); $('#btnList').css("pointer-events", "auto"); });;
        }
    }

    $("#btnList").click(function() { 
        //Pass in starting number.
        ShowCars(0, null, "2015");  
    });


});