public class Program {

    public static void main(String[] args) {
        System.out.println("Введите заказ:");
        Order order = new Order("", "", 0, 0);
        order.inputFromConsole();

        JSONSaver jSaver = new JSONSaver(order);
        jSaver.save();

        XMLSaver xSaver = new XMLSaver(order);
        xSaver.save();
        
        
    }

}