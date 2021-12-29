function navMobile() {
    let x = document.getElementById("nav_mobile-links");
    let y = document.getElementById("header_name")
    if (x.style.display === "block") {
        x.style.display = "none";
        y.style.display = "block";
    } else {
        x.style.display = "block";
        y.style.display = "none";
    }
}