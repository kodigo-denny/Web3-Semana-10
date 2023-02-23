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
}


class WritableDocument extends Document{

    constructor(data, filename){
        super(data, filename)
    }

    save(){
        console.log(`Archivo ${this.filename} almacenado`)
    }
}

class Project{
    allDocs
    writableDocs

    constructor(){
        this.allDocs = []
        this.writableDocs = []
    }

    agregarSoloLectura(doc){
        this.allDocs.push(doc)
    }

    agregarArchivo(doc){
        this.agregarSoloLectura(doc)
        this.writableDocs.push(doc)
    }

    openAll(){
        for(let item of this.allDocs){
            item.open()
        }
    }

    saveAll(){
        for(let item of this.writableDocs){
            item.save()
        }
    }
}