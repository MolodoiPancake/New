package Java.lesson_3;

import java.util.ArrayList;
import java.util.Arrays;

public class lesson_3_1 {
    public static void main(String[] args) {
        ArrayList<Integer> my_list = new ArrayList<>();
        for (int i = 0; i < 30; i ++){
            my_list.add(i);
        }
        System.out.println("Имеется список: \n" + my_list);
        for(int i = 0; i < my_list.size(); i ++){
            if(my_list.get(i) % 2 == 0){
                my_list.remove(i);
            }
        }
        System.out.println("Ответ: \n" + my_list);
    }
    
}

