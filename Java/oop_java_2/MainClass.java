public class MainClass {
    public static void main(String[] args) {

        Cat cat1 = new Cat("Barsik", 5);
        Cat cat2 = new Cat("Marsik", 7);
        Cat cat3 = new Cat("Persik", 10);
        Cat cat4 = new Cat("Shurik", 3);
        Cat cat5 = new Cat("Zmurik", 6);
        Cat cat6 = new Cat("Nulik", 5);

        Cat[] catsArray = new Cat[] { cat1, cat2, cat3, cat4, cat5, cat6 };

        Plate plate = new Plate(30);

        for (Cat cat : catsArray) {
            cat.eat(plate);
        }



        plate.info();
        plate.addFood(10);
        plate.info();


    }
}