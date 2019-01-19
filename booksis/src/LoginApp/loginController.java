package LoginApp;

import booksis.booksisController;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;
import javafx.scene.image.Image;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.stage.Stage;


import java.io.IOException;
import java.net.URL;
import java.sql.*;
import java.util.ResourceBundle;
import java.util.regex.Pattern;

public class loginController implements Initializable {



    @FXML
    private TextField tbxUsername;

    @FXML
    private PasswordField tbxPassword;

    @FXML
    private Button btnlogin;

    @FXML
    private Label lblLoginStatus;


    public void initialize(URL url, ResourceBundle rb) {


    }




    @FXML
    void login(ActionEvent event) throws Exception {

        Connection connection = null;
        PreparedStatement pr = null;
        ResultSet rs = null;



        try {
            connection = DriverManager.getConnection( "jdbc:sqlite:src//booksis.sqlite" );
            Class.forName( "org.sqlite.JDBC" );

            pr = connection.prepareStatement( "SELECT * FROM login where username = ? and password = ?" );
            pr.setString( 1, tbxUsername.getText());
            pr.setString( 2, tbxPassword.getText());
            rs = pr.executeQuery();

            if (rs.next()) {
                Stage stage = (Stage) this.btnlogin.getScene().getWindow();
                stage.close();
                booksis();

            } else {
                lblLoginStatus.setText( "Felaktiga information" );
                lblLoginStatus.setTextFill( Color.web("#ff0303") );
            }


        } catch (ClassNotFoundException e) {
            e.printStackTrace();


        } catch (SQLException e) {
            e.printStackTrace();
        }

    }

    public void booksis() {

        try {
            lblLoginStatus.setText( "Loggar in..." );
            lblLoginStatus.setTextFill( Color.web("#2bff05") );

            FXMLLoader booksisLoader = new FXMLLoader();
            Pane booksisRoot = (Pane)booksisLoader.load(getClass().getResource("..//booksis//booksis.fxml").openStream());
            Stage booksisStage = new Stage();
            booksisController booksisController = (booksisController)booksisLoader.getController();

            Scene scene = new Scene(booksisRoot);
            booksisStage.setScene(scene);
            booksisStage.setTitle("booksis");
            booksisStage.show();

        }catch (IOException e){
            e.printStackTrace();

            System.err.println("Error: "+e);
        }
    }
}
