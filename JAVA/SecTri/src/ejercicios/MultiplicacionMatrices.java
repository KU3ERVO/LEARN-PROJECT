package ejercicios;

import java.util.Arrays;

public class MultiplicacionMatrices {

	public static void main(String[] args) {

		// MULTIPLICAR MATRICES BUSCAR EN GOOGLE
		int[][] mat1 = {{1,2,3},{4,5,6}};
		int[][] mat2 = {{7,8},{9,10},{11,12}};
		// BUSCAR EN GOOGLE COMO SE MULTIPLICAN MATRICES
		int[][] mat3 = new int [2][2];
		int i=0,j=0,k=0,l=0;

		for(i=0;i<2;i++) {
			for(j=0;j<2;j++) {
				if(l==1) {l=0;}
				else {l=1;}
				for(k=0;k<3;k++) {

					mat3[i][l]+=mat1[i][k]*mat2[k][l];

				}
			}
		}

		for(i=0;i<2;i++) {
			for(j=0;j<2;j++) {
				System.out.print(mat3[i][j]+",");
			}
		}

	}

}
