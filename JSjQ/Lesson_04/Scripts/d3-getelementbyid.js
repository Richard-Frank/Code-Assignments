//No script tags needed.

console.log("External script file loaded.");

function Add()
{
    let firstNum = document.getElementById("txtFirstNumber").value;
    //console.log(firstNum);

    firstNum = parseFloat(firstNum);
    //console.log(typeof firstNum);

    let secondNum = Number(document.getElementById("txtSecondNumber").value);
    //console.log(secondNum);
    //console.log(typeof secondNum);

    let sumTotal = (firstNum + secondNum);
    //console.log(sumTotal);
    //console.log(typeof sumTotal);

    if(isNaN(sumTotal))
    {
        alert("Please enter valid numbers!")
        Clear();
    }
    else
    {
        document.getElementById("lblDisplay").innerHTML = sumTotal;
    }

}

function Clear()
{
    document.getElementById("lblDisplay").innerHTML = 0;
    document.getElementById("txtFirstNumber").value = "";
    document.getElementById("txtSecondNumber").value = "";

    document.getElementById("txtFirstNumber").focus();
}