// JavaScript source code
var player1 = 1;
var player2 = 2;
var presentPlayer = player1;
var arr = [[0, 0, 0], [0, 0, 0], [0, 0, 0]];
function canvas(a, b) {
    var id = "box(" + a + "," + b + ")";
    if (document.getElementById(id).classList.contains("crossimage")) return;
    if (document.getElementById(id).classList.contains("circleimage")) return;

    arr[a][b] = presentPlayer;

    if (presentPlayer === player1) {


        document.getElementById(id).classList.add("crossimage");
        if (haswon()) {
            alert("Player 1 won!");
            window.location.reload();
        }
        presentPlayer = player2;
    }
    else if (presentPlayer === player2) {

        document.getElementById(id).classList.add("circleimage");
        if (haswon()) {
            alert("Player 2 won!");
            window.location.reload();
        }
        presentPlayer = player1;

    }
    if(allBoxesFilled()) {
        alert("Game Draw");
        window.location.reload();
    }
    //if (haswon())
    //{
    //    alert("Player" + presentPlayer + " won!");
    //}
}
function haswon() {
    if (arr[0][0] === arr[1][0] && arr[1][0] === arr[2][0] && arr[0][0] !== 0) {return true;}
    else if (arr[0][0] === arr[1][1] && arr[1][1] === arr[2][2] && arr[0][0] != 0) { return true; }
    else if (arr[0][0] === arr[0][1] && arr[0][1] === arr[0][2] && arr[0][0] != 0) { return true; }
    else if (arr[0][2] === arr[1][1] && arr[1][1] === arr[2][0] && arr[0][2] != 0) { return true; }
    else if (arr[0][2] === arr[1][2] && arr[1][2] === arr[2][2] && arr[0][2] != 0) { return true; }
    else if (arr[0][2] === arr[0][1] && arr[0][1] === arr[0][0] && arr[0][2] != 0) { return true; }
    else if (arr[0][1] === arr[1][1] && arr[1][1] === arr[2][1] && arr[0][1] != 0) { return true; }
    else if (arr[1][0] === arr[1][1] && arr[1][1] === arr[1][2] && arr[1][0] != 0) { return true; }
    else if (arr[2][0] === arr[2][1] && arr[2][1] === arr[2][2] && arr[2][0] != 0) { return true; }
    else { return false; }
}
function allBoxesFilled()
{
    var result = true;
    for (i = 0; i < 3; i++)
    {
        for (j = 0; j < 3; j++)
        {
            if (arr[i][j] === 0)
            {
                return false;
            }
        }
    }
    return result;
}