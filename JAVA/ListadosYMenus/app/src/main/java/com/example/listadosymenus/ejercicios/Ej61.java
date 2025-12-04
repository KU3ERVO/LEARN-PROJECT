package com.example.listadosymenus.ejercicios;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.listadosymenus.R;

public class Ej61 extends AppCompatActivity {

    ListView lv;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.actividad1_layout);

        lv = findViewById(R.id.listViewPlanetas);

        String[] videogames =  {"METROID","ZELDA","BAYONETTA","HOLLOW KNIGHT",
        "DARK SOULS","BLASPHEMOUS","SMASH BROS","BATMAN ARKHAM","LEAGUE"};

        ArrayAdapter <String> adp = new ArrayAdapter<>(
                this, android.R.layout.simple_list_item_1,videogames);

        lv.setAdapter(adp);

    }
}
