document.addEventListener("DOMContentLoaded", function () {
    applyTheme(); // Aplica o tema salvo

    // Se houver um dropdown na página, sincroniza com o cookie
    var select = document.getElementById("ddlDarkMode");
    if (select) {
        select.value = getCookie("theme") || "default";
    }
});

function applyTheme() {
    var theme = getCookie("theme") || "default";
    document.body.classList.remove("dark-mode", "light-mode", "default-theme");

    if (theme === "dark") {
        document.body.classList.add("dark-mode");
    } else if (theme === "light") {
        document.body.classList.add("light-mode");
    } else {
        document.body.classList.add("default-theme");
    }
}

function setTheme(value) {
    document.cookie = "theme=" + value + "; path=/; max-age=" + (30 * 24 * 60 * 60);
    applyTheme();
}

function getCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i].trim();
        if (c.indexOf(nameEQ) === 0) {
            return c.substring(nameEQ.length, c.length);
        }
    }
    return "";
}
