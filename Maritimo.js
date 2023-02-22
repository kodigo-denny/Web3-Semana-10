class Maritimo extends Shipping{

    getCost(order){
        return order.getTotalWeight()*5
    }

    getDate(){
        return new Date()
    }
}