package Java.lesson_2;

public class working {
    public static void main(String[] args) {
            System.out.println();
    }

    static String str(int number, String firstChar, String secondChar) {
        StringBuilder result = new StringBuilder();
        String twoChars = firstChar + secondChar;
        for (int i = 0; i < number / 2; i++) {
            result.append(twoChars);
            return result.toString();
        }
    }

}
