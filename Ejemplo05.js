class Document{
    data
    filename

    constructor(data, filename){
        this.data = data
        this.filename = filename
    }

    open(){
        console.log(`Archivo ${this.filename} aperturado`)
    }

    save(){
        console.log(`Archivo ${this.filename} almacenado`)
    }
}

class ReadOnlyDocument extends Document{

    constructor(data, filename){
        super(data, filename)
    }

    save(){
        alert("Error es un archivo de solo lectura")
    }
}

class Project{
    documents

    constructor(){
        this.documents = []
    }

    openAll(){
        for(let item of this.documents){
            item.open()
        }
    }

    saveAll(){
        for(let item of this.documents){
            item.save()
        }
    }
}