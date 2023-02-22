class Order{
    lineItems
    shipping
    total
    peso

    constructor(shipping){
        this.lineItems = []
        this.shipping = shipping
    }

    getTotal(){
        return this.total
    }

    getTotalWeight(){
        return this.peso
    }

    setShippingType(st){
        this.shipping = st
    }

    getShippingCost(){
        return this.shipping.getCost(this)
    }

    getShippingDate(){
        return this.shipping.getDate()
    }
}