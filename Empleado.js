class Empleado{
    nombre
    apellido

    constructor(nombre, apellido){
        this.nombre = nombre
        this.apellido = apellido
    }

    getName(){
        return  this.apellido + ", " + this.nombre
    }

    informeHorasTrabajoSemanal(horas){
        return horas * 7
    }

    informeHorasTrabajoQuincenal(horas){
        return horas * 15
    }

}