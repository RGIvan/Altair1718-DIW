function PortuguesAEspañol() {
    españoles = document.getElementsByClassName("esp");
    portugues = document.getElementsByClassName("por");
    for (var i = 0; i < españoles.length; i++) {
        españoles[i].className = "esp visible";
    }
    for (var i = 0; i < portugues.length; i++) {
        portugues[i].className = "por hidden";
    }
}
function EspañolAPortugues() {
    españoles = document.getElementsByClassName("esp");
    portugues = document.getElementsByClassName("por");
    for (var i = 0; i < portugues.length; i++) {
        portugues[i].className = "por visible";
    }
    for (var i = 0; i < españoles.length; i++) {
        españoles[i].className = "esp hidden";
    }
}
/* function PortuguesAEspañol(idioma1,idioma2) {
                    eltosIdioma1 = document.getElementsByClassName(idioma1);
                    eltosIdioma2 = document.getElementsByClassName(idioma2);
                    for (var i = 0; i < idioma1.length; i++) {
                        eltosIdioma1[i].className = idioma1+" mostrar";
                        eltosIdioma2[i].className = idioma2+" ocultar";
                    }

                }*/