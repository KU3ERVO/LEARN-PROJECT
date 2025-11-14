package ejercicios;

import android.os.Bundle;
import android.text.InputType;
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
        EditText edtxtContrasena = findViewById(R.id.editTextNumberPassword);

        edtxtTelefono.setInputType( InputType.TYPE_CLASS_PHONE);
        edtxtContrasena.setInputType(InputType.TYPE_CLASS_NUMBER | InputType.TYPE_NUMBER_VARIATION_PASSWORD);
        edtxtCorreo.setInputType(InputType.TYPE_CLASS_TEXT | InputType.TYPE_TEXT_VARIATION_EMAIL_ADDRESS);
        edtxtNumero.setInputType(InputType.TYPE_CLASS_NUMBER);

    }
}
