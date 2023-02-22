class TimeSheetReport{



    static informeHorasTrabajoSemanal(horas, emp){
        console.log(`${emp.getName()} horas totales: ${horas * 7}`)
    }

    static informeHorasTrabajoQuincenal(horas, emp){
        console.log(`${emp.getName()} horas totales: ${horas * 15}`)
    }
}