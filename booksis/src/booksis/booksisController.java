package booksis;

import com.sun.xml.internal.bind.v2.schemagen.episode.Klass;
import javafx.beans.Observable;
import javafx.collections.FXCollections;
import javafx.collections.ObservableArray;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Scene;
import javafx.scene.control.*;
import LoginApp.loginController;
import javafx.scene.control.Label;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.stage.Stage;
import javafx.collections.ObservableList;


import javax.swing.*;
import java.awt.*;
import java.io.IOException;
import java.net.URL;
import java.sql.*;
import java.time.LocalDate;
import java.util.ResourceBundle;
import java.util.concurrent.ThreadLocalRandom;


public class booksisController implements Initializable {

    @FXML
    public Label dbStatus;

    @FXML
    public javafx.scene.control.TextField studentName;
    @FXML
    private javafx.scene.control.TextField klass;
    @FXML
    private javafx.scene.control.TextField course;
    @FXML
    private javafx.scene.control.TextField Bookname;
    @FXML
    private javafx.scene.control.TextField booknumber;
    @FXML
    private DatePicker utDate;
    @FXML
    private DatePicker åtDate;
    @FXML
    private TableView<bookData> booktable;


    @FXML
    private TableColumn<bookData, String> nameColumn;
    @FXML
    private TableColumn<bookData, String> klasscolumn;
    @FXML
    private TableColumn<bookData, String> kurscolumn;
    @FXML
    private TableColumn<bookData, String> boknamnColumn;
    @FXML
    private TableColumn<bookData, String> bokNummerColumn;
    @FXML
    private TableColumn<bookData, String> utdatumColumn;
    @FXML
    private TableColumn<bookData, String> åtdatumColumn;
    @FXML
    private TableColumn<bookData, String> studentIDcolumn;

    private loginController lc;
    private ObservableList<bookData> data;

   public static int id = ThreadLocalRandom.current().nextInt(1, 5000 +1);



    private String sql= "SELECT  * FROM Booksis";

    public void initialize(URL url, ResourceBundle rb){

        this.lc = new loginController();

    }






    public void loadBookData(ActionEvent event) {

        try {
            PreparedStatement pr = null;



            Connection conn = DriverManager.getConnection( "jdbc:sqlite:src//booksis.sqlite" );
            this.data= FXCollections.observableArrayList();

            ResultSet rs= conn.createStatement().executeQuery(sql);

            while (rs.next()){
                this.data.add(new bookData(rs.getString(1),rs.getString(2), rs.getString(3), rs.getString(4),rs.getString(5), rs.getString(6), rs.getString(7), rs.getString(8)));

            }

        }catch (SQLException e){
            System.err.println("Error: "+e);
        }

        this.studentIDcolumn.setCellValueFactory(new PropertyValueFactory<bookData, String>("id"));
        this.nameColumn.setCellValueFactory(new PropertyValueFactory<bookData, String>("studentName"));
        this.klasscolumn.setCellValueFactory(new PropertyValueFactory<bookData, String>("Klass"));
        this.kurscolumn.setCellValueFactory(new PropertyValueFactory<bookData, String>("course"));
        this.boknamnColumn.setCellValueFactory(new PropertyValueFactory<bookData, String>("Bookname"));
        this.bokNummerColumn.setCellValueFactory(new PropertyValueFactory<bookData, String>("booknumber"));
        this.utdatumColumn.setCellValueFactory(new PropertyValueFactory<bookData, String>("utDate"));
        this.åtdatumColumn.setCellValueFactory(new PropertyValueFactory<bookData, String>("åtDate"));

        this.booktable.setItems(null);
        this.booktable.setItems(this.data);


    }

    public void addBook(ActionEvent event) {

        this.id += 1;
        System.out.println(id);
        String sqlInsert = "INSERT INTO Booksis(id, namn,klass,kurs,boknamn,boknummer,uTdatum,aLDatum) VALUES(?,?,?,?,?,?,?,?)";
        try {


            Connection conn = DriverManager.getConnection("jdbc:sqlite:src//booksis.sqlite");
            PreparedStatement stmt = conn.prepareStatement(sqlInsert);

                stmt.setInt(1, this.id);
                stmt.setString(2,this.studentName.getText());
                stmt.setString(3,this.klass.getText());
                stmt.setString(4,this.course.getText());
                stmt.setString(5,this.Bookname.getText());
                stmt.setString(6,this.booknumber.getText());
                stmt.setString(7,this.utDate.getEditor().getText());
                stmt.setString(8,this.åtDate.getEditor().getText());

            stmt.execute();
            conn.close();

        }catch (SQLException e){
            System.err.println("Error: "+e);

        }

    }

    public void clearField(ActionEvent event) {

            this.studentName.setText("");
            this.klass.setText("");
            this.course.setText("");
            this.Bookname.setText("");
            this.booknumber.setText("");
            this.utDate.setValue(null);
            this.åtDate.setValue(null);
    }



    public void openAdminPanel(ActionEvent event) {

        try {

            FXMLLoader adminLoader = new FXMLLoader();
            Pane adminRoot = (Pane)adminLoader.load(getClass().getResource("..//admin//AdminController.fxml").openStream());
            Stage adminStage = new Stage();
            admin.adminController adminController = (admin.adminController)adminLoader.getController();

            Scene scene = new Scene(adminRoot);
            adminStage.setScene(scene);
            adminStage.setTitle("Admin Controller");
            adminStage.show();

        }catch (IOException e){
            System.err.println("Error: "+e);
        }

    }

    public void loadRow(ActionEvent event){


        Object selectedrow = booktable.getSelectionModel().getSelectedCells().get(0);
        int row = ((TablePosition) selectedrow).getRow();
        TableColumn col  = ((TablePosition) selectedrow).getTableColumn();
        String data = (String)col.getCellObservableValue(row).getValue();

        System.out.println("col: " + col + " row: "+ row + " Data: " + data);

        try {
            String name= studentName.getText();
            String Klass = klass.getText();
            String kurs = course.getText();
            String boknamn = Bookname.getText();
            String boknummer = booknumber.getText();
            String utdata = String.valueOf(utDate.getValue());
            String åtdate = String.valueOf(åtDate.getValue());


            String sql="UPDATE Booksis  set (namn, klass, kurs, boknamn, boknummer, uTdatum, aLDatum) values (?,?,?,?,?,?,?)  where id = ? value(?)";
            Connection conn = DriverManager.getConnection("jdbc:sqlite:src//booksis.sqlite");
            PreparedStatement stmt = conn.prepareStatement(sql);

            if (selectedrow != null) {
                stmt.setString(1, this.studentName.getText());
                stmt.setString(2, this.klass.getText());
                stmt.setString(3, this.course.getText());
                stmt.setString(4, this.Bookname.getText());
                stmt.setString(5, this.booknumber.getText());
                stmt.setString(6, this.utDate.getEditor().getText());
                stmt.setString(7, this.åtDate.getEditor().getText());
                stmt.setString(8, data);


            }
        }catch (SQLException e){
            System.err.println("Load error: " + e);
        }

    }

    public void removeRow(ActionEvent event){

        booktable.getItems().removeAll(booktable.getSelectionModel().getSelectedItem());


    }
}
