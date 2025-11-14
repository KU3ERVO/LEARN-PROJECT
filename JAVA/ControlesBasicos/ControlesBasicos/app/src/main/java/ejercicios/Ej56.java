package ejercicios;

import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.view.View;
import android.widget.Button;
import android.widget.ProgressBar;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.controlesbasicos.R;

public class Ej56 extends AppCompatActivity implements View.OnClickListener{


    Button btn;
    Handler handler = new Handler();

    ProgressBar barra;
    TextView txt;
    boolean isActivo = false;
    int i = 0;
    Intent x;
    String append = "0%";

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_5_6);

        barra = findViewById(R.id.progressBarLineal);
        txt = findViewById(R.id.textViewProgreso);
        btn = findViewById(R.id.btnProgressBar);
        btn.setOnClickListener(this);

    }

    @Override
    public void onClick(View v) {

        if(v.getId() == R.id.btnProgressBar){

            if(!isActivo){
                isActivo = true;
                Thread hilo = new Thread(new Runnable() {
                    @Override
                    public void run() {
                        while(i<=1000){
                            handler.post(new Runnable() {
                                @Override
                                public void run() {
                                    txt.setText("ANGEL MIGIEL FELIPE\n PROGRESS BAR\n" + i +"%");
                                    barra.setProgress(i/10);
                                }
                            });
                            try {
                                Thread.sleep(10);
                            } catch (InterruptedException e) {
                                throw new RuntimeException(e);
                            }
                            if(i==1000){
                                x = new Intent(Ej56.this,Ej52.class);
                                startActivity(x);
                            }
                            i++;
                        }

                    }
                });
                hilo.start();

            }

        }

    }
}
