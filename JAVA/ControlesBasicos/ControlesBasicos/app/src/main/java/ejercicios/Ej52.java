package ejercicios;

import android.os.Build;
import android.os.Bundle;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.TextView;

import androidx.annotation.RequiresApi;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;
import androidx.annotation.Nullable;


import com.example.controlesbasicos.R;

public class Ej52 extends AppCompatActivity {

    @RequiresApi(api = Build.VERSION_CODES.O)
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_5_1);

        TextView ttle = findViewById(R.id.tvTitulo);
        ttle.setTypeface(getResources().getFont(R.font.jacquard12_regular));
        ttle.setTextSize(ttle.getTextSize());
        ttle.setTextColor(ContextCompat.getColor(this,R.color.black));
        ttle.setText("Angel Miguel Felipe");

            ttle.startAnimation(AnimationUtils.loadAnimation(this,R.anim.rotar1));


    }
}
