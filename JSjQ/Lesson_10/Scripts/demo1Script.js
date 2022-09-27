$(function(){ 
    console.log("Script Loaded");
    let winner


    //Literal notation, data set similar to Key Value Pair.
    var Employee = {
        Name:"John Smith",
        Email:"Email@Email.com",
        Age:"30",
        displayMessage:function() { alert("This is " + this.Name + "'s message.") }
    }

    //Object constructor
    var NewEmp = function() { 
        this.Name = "John Smith",
        this.Email = "Email@Email.com",
        this.Age = "30",
        this.displayMessage = function() { alert("This is " + this.Name + "'s message.") }
    };

    function Person(name, age, sex)
    {
        this.name = name;
        this.age = age;
        this.sex = sex;
    }

    let players = [
        new Person('Guy', "35", "M"),
        new Person("Sue", "45", "F"),
        new Person("Esme", "73", "F"),
        new Person("Fred", "21", "M"),
        new Person("Dorothy", "61", "F"),
        new Person("Testmun", "38", "M")
    ];


    $('#btnWinner').click(function() { 

        winner = Math.floor(Math.random() * players.length);

        document.getElementById("lblName").innerHTML = players[winner].name;
    });

    $('#btnAge').click(getAge);

    function getAge()
    {
        if(winner != null)
        {
        document.getElementById("lblAge").innerHTML = players[winner].age;
        }
    }
    $('#btnMessage').click(function() { 

        //Employee.displayMessage();

        //Literals will all act as one, a single change effects all.
        /*
        newEmp = Employee;
        alert(newEmp.Name);
        alert(Employee.Name);
        newEmp.Name = "Robert Banks";
        alert(newEmp.Name);
        alert(Employee.Name);
        */
        emp1 = new NewEmp();
        emp2 = new NewEmp();
        emp1.displayMessage();
        emp2.displayMessage();
        //Case sensative.
        emp1.Name = "Robert Banks";
        emp1.displayMessage();
        emp2.displayMessage();


    });



});