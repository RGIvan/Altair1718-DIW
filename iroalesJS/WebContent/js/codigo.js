function validarNombre(campo) {
	if (campo.value == null || campo.value.length == 0
			|| /^\s+$/.test(campo.value)) {
		mostrarErrorNombre(campo.id, "Error: Nombre vacío");
	} else {
		borrarErrorNombre(campo.id);
	}
}

function validarLongitudNombre(campo){
	if (campo.value.length > 20 || /^\s+$/.test(campo.value)) {
		mostrarErrorLongitudNombre(campo.id, "Error en nombre: longitud mayor que 20");
	} else {
		borrarErrorLongitudNombre(campo.id);
	}
}

function validarApellidos(campo) {
	if (campo.value == null || campo.value.length == 0
			|| /^\s+$/.test(campo.value)) {
		mostrarErrorApellidos(campo.id, "Error: Apellido vacío");
	} else {
		borrarErrorApellidos(campo.id);
	}
}

function validarLongitudApellidos(campo){
	if (campo.value.length > 20 || /^\s+$/.test(campo.value)) {
		mostrarErrorLongitudApellidos(campo.id,
				"Error en apellidos: longitud mayor que 20");
	} else {
		mostrarErrorLongitudApellidos(campo.id);
	}
}

function validarContraseña(campo) {
	if (campo.value == null || campo.value.length == 0
			|| /^\s+$/.test(campo.value)) {
		mostrarErrorContraseña(campo.id, "Error: Contraseña vacía");
	} else {
		borrarErrorContraseña(campo.id);
	}
}

function validarContraseñaRepetida(campo) {
	if (campo.value == null || campo.value.length == 0
			|| /^\s+$/.test(campo.value)) {
		mostrarErrorContraseñaRepetida(campo.id,
				"Error: Contraseña repetida vacía");
	} else {
		mostrarErrorContraseñaRepetida(campo.id);
	}
}

function mostrarErrorLongitudNombre(id, texto) {
	document.getElementById("sp" + id).innerHTML = texto;
}

function borrarErrorLongitudNombre(id, texto) {
	document.getElementById("sp" + id).innerHTML = "";
}

function mostrarErrorLongitudApellidos(id, texto) {
	document.getElementById("sp" + id).innerHTML = texto;
}

function borrarErrorLongitudApellidos(id, texto) {
	document.getElementById("sp" + id).innerHTML = "";
}

function mostrarErrorNombre(id, texto) {
	document.getElementById("sp" + id).innerHTML = texto;
}

function borrarErrorNombre(id) {
	document.getElementById("sp" + id).innerHTML = "";
}

function mostrarErrorApellidos(id, texto) {
	document.getElementById("sp" + id).innerHTML = texto;
}

function borrarErrorApellidos(id) {
	document.getElementById("sp" + id).innerHTML = "";
}

function mostrarErrorContraseña(id, texto) {
	document.getElementById("sp" + id).innerHTML = texto;
}

function borrarErrorContraseña(id, texto) {
	document.getElementById("sp" + id).innerHTML = texto;
}

function mostrarErrorContraseñaRepetida(id, texto) {
	document.getElementById("sp" + id).innerHTML = texto;
}

function borrarErrorContraseñaRepetida(id, texto) {
	document.getElementById("sp" + id).innerHTML = texto;
}

function validarFormulario() {
	var elementos = document.getElementsByName("estado");
	for (var i = 0; i < elementos.length; i++) {
		alert(elementos[i].value + " - " + elementos[i].checked);
	}
	return true;
}

function validarEmail(campo) {
	if (!esCorrectoEmail(campo.value)) {
		mostrarError(campo.id, "Error: Email incorrecto");
	} else {
		borrarError(campo.id);
	}
}

function esCorrectoEmail(mail) {
	return /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(mail);
}