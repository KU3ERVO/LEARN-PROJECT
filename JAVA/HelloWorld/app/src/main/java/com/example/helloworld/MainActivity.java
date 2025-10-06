package com.example.helloworld;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        Log.i("ANGEL", "Estoy onCreate");
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

    }

    @Override
    protected void onStart() {
        super.onStart();
        Log.i("ANGEL", "Estoy onStart");
    }
    @Override
    protected void onStop() {
        super.onStop();
        Log.i("ANGEL", "Estoy onStop");
    }
    @Override
    protected void onResume() {
        super.onResume();
        Log.i("ANGEL", "Estoy onResume");
    }
    @Override
    protected void onPause() {
        super.onPause();
        Log.i("ANGEL", "Estoy onPause");
    }
    @Override
    protected void onRestart() {
        super.onRestart();
        Log.i("ANGEL", "Estoy onRestart");
    }
    @Override
    protected void onDestroy() {
        super.onDestroy();
        Log.i("ANGEL", "Estoy onDestroy");

        Intent ex = new Intent(this,MainActivity2.class);
        startActivity(ex);
    }
}