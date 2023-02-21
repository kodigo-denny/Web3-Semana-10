function pedirNumeros(){
    let num1 = Number(prompt("Num1: "))
    let num2 = Number(prompt("Num2: "))
    let resultado = sumar(num1, num2)
    mostrarResultado(resultado)
}

function mostrarResultado(res){
    alert(res)
}

function sumar(num1, num2){
    return num1 + num2
}

function restar(num1, num2){
    return num1 - num2
}