package dao;

import java.io.IOException;
import java.sql.Connection;
import java.sql.SQLException;

public class Main {
    public static void main(String[] args) throws IOException {
        try {
            DBConnector dbc = new DBConnector();
            Connection con = dbc.connection;

            if (con == null) {
                throw new Exception("error conexion");
            }
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
}
