function enviar() {
	if (document.getElementById("checkbox").checked) {
		localStorage.setItem("localStorage", document.formulario.usuario.value);
	} else {
		localStorage.removeItem("localStorage");
	}
	return true;
}

function irComic() {
	window.top.location.href = ("comic.html");
}

function irIndex() {
	window.top.location.href = ("index.html");
}

function carga() {
	document.getElementById("var").innerHTML = localStorage.getItem("localStorage");
}

function init() {
	var usuario = localStorage.getItem("localStorage");
	if (usuario != null) {
		document.getElementById("usuario").value = usuario;
	}
}

window.addEventListener("load", init(), false);