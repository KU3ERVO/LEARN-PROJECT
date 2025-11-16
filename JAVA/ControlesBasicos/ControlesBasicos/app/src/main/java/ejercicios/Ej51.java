package ejercicios;

import android.graphics.Typeface;
import android.os.Build;
import android.os.Bundle;
import android.widget.TextView;




import androidx.activity.EdgeToEdge;
import androidx.annotation.RequiresApi;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.controlesbasicos.R;

public class Ej51 extends AppCompatActivity {

    @RequiresApi(api = Build.VERSION_CODES.O)
    @Override
    public void onCreate( Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_5_1);

        TextView ttle = findViewById(R.id.tvTitulo);
        ttle.setTypeface(getResources().getFont(R.font.jacquard12_regular));
        ttle.setTextSize(ttle.getTextSize());
        ttle.setTextColor(ContextCompat.getColor(this,R.color.black));
        ttle.setText("Angel Miguel Felipe");

        TextView content = findViewById(R.id.tvContenido);
        //content.setTypeface(Typeface.DEFAULT_BOLD);
        //content.setTypeface(Typeface.defaultFromStyle(Typeface.ITALIC));
        content.setTypeface(getResources().getFont(R.font.jacquard12_regular));
        content.setTextSize(20);
        content.setTextColor(ContextCompat.getColor(this, com.google.android.material.R.color.design_default_color_error));
        //content.setTextColor(ContextCompat.getColor(this,R.color.custom_blue));
        //content.setText("Texto construido desde XML Tamaño 20sp, Italic color Blue");
        content.setText("Jaquard Regular");
        //content.append(" Texto añadido con append");
    }
}
