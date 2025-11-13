package ejercicios;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.controlesbasicos.R;

public class Ej53 extends AppCompatActivity implements View.OnClickListener {

    private TextView tvMensaje;

    @Override
    protected void onCreate( Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_5_3_java);

        Button btn1 = findViewById(R.id.btnBoton1);
        btn1.setOnClickListener(this);

        Button btn2 = findViewById(R.id.btnBoton2);
        btn2.setOnClickListener(this);
    }

    @Override
    protected void onRestart() {
        super.onRestart();
        setContentView(R.layout.activity_5_3_on_click);

        Button btn3 = findViewById(R.id.btnPulsar);
        btn3.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        int id = v.getId();

        tvMensaje = findViewById(R.id.tvMensaje);

        if(id == R.id.btnBoton1){
            tvMensaje.setText(R.string.boton_1_pulsado);
            tvMensaje.setTextColor(ContextCompat.getColor(this,R.color.custom_blue));
        }
        if(id == R.id.btnBoton2){
            tvMensaje.setText(R.string.boton_2_pulsado);
            tvMensaje.setTextColor(ContextCompat.getColor(this, com.google.android.material.R.color.design_default_color_error));
        }
        if(id == R.id.btnPulsar){
            tvMensaje.setText(R.string.boton_pulsado);
            tvMensaje.setTextColor(ContextCompat.getColor(this, com.google.android.material.R.color.design_default_color_error));
        }

    }
}
