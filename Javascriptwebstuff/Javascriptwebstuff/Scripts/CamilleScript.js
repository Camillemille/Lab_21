var check_match = function () {
    if (document.getElementById("email").value ===
        document.getElementById("confirmemail").value) {
        document.getElementById("message").style.color = "pink";
        document.getElementById("message").innerHTML = "Matching";
    }
    else {
        document.getElementById("message").style.color = "purple";
        document.getElementById("message").innerHTML = "NOT MATCHING";
    }


}