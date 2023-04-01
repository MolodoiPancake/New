package Java.lesson_1;

import java.util.Scanner;

public class task_1 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int sum = 0;
        int product = 1;
        System.out.println("Введите число");
        int number = sc.nextInt();
            for (int i = 0; i < number + 1; i++) {
                sum = sum + i;
            }
                System.out.println(sum);
            for (int j = 1; j < number + 1; j++) {
                product = product * j;
                
        }
        System.out.println(product);
    }
}