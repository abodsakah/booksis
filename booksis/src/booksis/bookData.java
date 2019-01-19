package booksis;

import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;

public class bookData {

    private final StringProperty id;
    private final StringProperty name;
    private final StringProperty Klass;
    private final StringProperty course;
    private final StringProperty bookName;
    private final StringProperty bookNumber;
    private final StringProperty utDate;
    private final StringProperty åtDate;

    public bookData(String studentID,String name, String _Class, String course, String bookName, String bookNumber, String utDate, String åtDate){

        this.id = new SimpleStringProperty(studentID);
        this.name = new SimpleStringProperty(name);
        this.Klass = new SimpleStringProperty(_Class);
        this.course = new SimpleStringProperty(course);
        this.bookName= new SimpleStringProperty(bookName);
        this.bookNumber= new SimpleStringProperty(bookNumber);
        this.utDate = new SimpleStringProperty(utDate);
        this.åtDate = new SimpleStringProperty(åtDate);

    }

    public String getId() {
        return id.get();
    }

    public StringProperty idProperty() {
        return id;
    }

    public void setId(String id) {
        this.id.set(id);
    }

    public String getStudentName() {
        return name.get();
    }

    public StringProperty studentNameProperty() {
        return name;
    }

    public void setStudentName(String name) {
        this.name.set(name);
    }

    public String getKlass() {
        return Klass.get();
    }

    public StringProperty klassProperty() {
        return Klass;
    }

    public void setKlass(String Klass) {
        this.Klass.set(Klass);
    }

    public String getCourse() {
        return course.get();
    }

    public StringProperty courseProperty() {
        return course;
    }

    public String getBookname() {
        return bookName.get();
    }

    public StringProperty booknameProperty() {
        return bookName;
    }

    public void setBookname(String bookName) {
        this.bookName.set(bookName);
    }

    public String getBooknumber() {
        return bookNumber.get();
    }

    public StringProperty booknumberProperty() {
        return bookNumber;
    }

    public void setBooknumber(String bookNumber) {
        this.bookNumber.set(bookNumber);
    }

    public String getUtDate() {
        return utDate.get();
    }

    public StringProperty utDateProperty() {
        return utDate;
    }

    public void setUtDate(String utDate) {
        this.utDate.set(utDate);
    }

    public String getÅtDate() {
        return åtDate.get();
    }

    public StringProperty åtDateProperty() {
        return åtDate;
    }

    public void setÅtDate(String åtDate) {
        this.åtDate.set(åtDate);
    }
}
