function calcularMenu(){
	var lapiz = document.getElementById("lapiz").value;
	var rotulador = document.getElementById("rotulador").value;
	var libreta = document.getElementById("libreta").value;
	
	var total = (lapiz * 2.5) + (rotulador * 3.2) + (libreta * 5.4);
	
	document.getElementById("total").innerHTML = total;
}

function borrarMenu(){
	document.getElementById("lapiz").value = "";
	document.getElementById("rotulador").value = "";
	document.getElementById("libreta").value = "";
	document.getElementById("total").innerHTML = "";
}

function validarEmail(campo) {
	if (!esCorrectoEmail(campo.value)) {
		mostrarError(campo.id);
	} else {
		borrarError(campo, id);
	}
}

function esCorrectoEmail(mail) {
	return /^[-\w.%+]{1,64}@(?:[A-Z0-9-]{1,63}\.){1,125}[A-Z]{2,63}$/
			.test(mail);
}

function mostrarError(id, texto) {
	document.getElementById("sp" + id).innerHTML = texto;
}

function borrarError(id) {
	document.getElementById("sp" + id).innerHTML = "";
}

function validar(campo) {
	if (campo.value == null || campo.value.length == 0
			|| /^\s+$/.test(campo.value)) {
		mostrarError(campo.id, "Error: El campo está vacío.");
	} else {
		borrarError(campo.id);
	}
}