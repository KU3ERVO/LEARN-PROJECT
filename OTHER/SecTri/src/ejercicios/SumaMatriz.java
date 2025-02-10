package ejercicios;

public class SumaMatriz {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		// MULTIPLICAR MATRICES BUSCAR EN GOOGLE
		int[][] mat1 = {{1,2},{3,4},{5,6}};
		int[][] mat2 = {{7,8},{9,10},{11,12}};
		// BUSCAR EN GOOGLE COMO SE MULTIPLICAN MATRICES
		int[][] mat3 = new int [3][3];
		int i=0,j=0,k=0,l=0;

		for(i=0;i<3;i++) {
			for(j=0;j<2;j++) {
				
				mat3[i][j]=mat1[i][j]+mat2[i][j];
				
			}
		}

		for(i=0;i<3;i++) {
			for(j=0;j<2;j++) {
				System.out.print(mat3[i][j]+",");
			}
		}

	}

}
