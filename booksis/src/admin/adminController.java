package admin;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Label;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;
import javafx.scene.paint.Color;

import java.awt.*;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class adminController {

    @FXML
    private TextField tbUser;
    @FXML
    private PasswordField tbxPass;
    @FXML
    private Label lblStatus;


    public void addUser(ActionEvent event) {

        String sqlInsert = "INSERT INTO login(username,password) VALUES(?,?)";
        try {
            if(!tbUser.getText().equals("")&&!tbxPass.getText().equals("")) {
                Connection conn = DriverManager.getConnection("jdbc:sqlite:src//booksis.sqlite");
                PreparedStatement ps = conn.prepareStatement(sqlInsert);
                ps.setString(1, this.tbUser.getText());
                ps.setString(2, this.tbxPass.getText());
                lblStatus.setText("✔ uppdaterade databasen");
                lblStatus.setTextFill(Color.web("#219e02"));
                ps.execute();
                conn.close();
            }else {
                lblStatus.setText("✗ fill in informationen");
                lblStatus.setTextFill(Color.web("#d11919"));
            }

        }catch (SQLException e){
            System.err.println("Error: "+e);

        }
    }

    public void clear(ActionEvent event){
        this.tbUser.setText("");
        this.tbxPass.setText("");
        this.lblStatus.setText("");
    }
}
