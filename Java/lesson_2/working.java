package Java.lesson_2;

import java.util.Scanner;

public class working {
public static void main(String[] args) {
        System.out.println("Введите число -->  ");
        Scanner sc = new Scanner(System.in);
        int last_num = sc.nextInt();
        sc.close();
        int result_sum = 0;
        int result_mult = 1;
        for (int i = 1; i <= last_num; i++){
            result_sum += i;
            result_mult *= i;
        }
        System.out.println("Treugolnoe chislo = " + result_sum);
        System.out.println("n! = " + result_mult);
    }

}
