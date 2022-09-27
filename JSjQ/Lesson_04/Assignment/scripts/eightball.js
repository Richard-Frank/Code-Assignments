
//console.log("8Ball script file loaded.");

aryAnswers = new Array();

aryAnswers[0] = "Ask again later…";
aryAnswers[1] = "Yes.";
aryAnswers[2] = "No.";
aryAnswers[3] = "It appears to be so.";
aryAnswers[4] = "Yes, definitely.";
aryAnswers[5] = "What is it you <i>really</i> want to know?";
aryAnswers[6] = "Outlook is good.";
aryAnswers[7] = "My sources say no.";
aryAnswers[8] = "Signs point to yes.";
aryAnswers[9] = "Do not count on it.";
aryAnswers[10] = "Cannot predict now.";
aryAnswers[11] = "As I see it, yes.";
aryAnswers[12] = "Better not tell you now.";
aryAnswers[13] = "You don't really want the answer.";
aryAnswers[14] = "Look inside yourself for the real answer.";
aryAnswers[15] = "Absolutely no chance.";
aryAnswers[16] = "I cannot answer that question due to national security concerns.";

let previousAnswer;

function Answer()
{
    let input = document.getElementById("txtInput").value;
    //console.log(input);
    let questionChar = input.charAt(input.length-1);
    //console.log(questionChar);

    if(questionChar === "?")
    {
        if(input !== previousAnswer)
        {
            let answer = aryAnswers[Math.floor(Math.random() * aryAnswers.length)];
            document.getElementById("lblOutput").innerHTML = answer;
            previousAnswer = input;
            //console.log(previousAnswer);
        }
        else
        {
            alert("Don't keep asking the same question!")
            document.getElementById("txtInput").focus();
        }
    }
    else
    {
        alert("All questions must end with a question mark.")
        document.getElementById("txtInput").focus();
        document.getElementById("lblOutput").innerHTML = "<i>...</i>";
    }

}
function Clear()
{
    document.getElementById("txtInput").value = "";
    document.getElementById("txtInput").focus();
}