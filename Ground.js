class Ground{
    getCost(order){
        if(order.getTotal()>100){
            return 0
        }

        return order.getTotalWeight() * 1.5
    }

    getDate(){
        return new Date()
    }
}