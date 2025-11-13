package ejercicios;

import android.os.Bundle;
import android.widget.EditText;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.controlesbasicos.R;

public class Ej54 extends AppCompatActivity {

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_5_4);

        EditText edtxtTelefono = findViewById(R.id.editTextPhone);
        EditText edtxtCorreo = findViewById(R.id.editTextEmail);
        EditText edtxtNumero = findViewById(R.id.editTextNumber);
        EditText edtxtContraseña = findViewById(R.id.editTextNumberPassword);

edtxtTelefono.setInputType();

    }
}
