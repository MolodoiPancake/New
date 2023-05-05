package presenters;
import java.util.Date;

public class ViewObserver {
    
    void onReservationTable(Date orderDate, int tableNo, String name);

    void onChangeReservationTable(int oldReservation,Date orderDate, int tableNo, String name);
}
