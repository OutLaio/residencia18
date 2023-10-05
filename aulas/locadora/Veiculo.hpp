#if !defined(VEICULO_HPP)
#define VEICULO_HPP

#include<iostream>
#include<string>
#include<vector>

using namespace std;

class Veiculo{
    private:
        string placa;
        string marca;
        string modelo;
        int ano;
        float precoDiario;
    public:
        Veiculo(string _placa, string _marca, string _modelo, int _ano, float _precoDiario);
        void setPlaca(string _placa);
        void setMarca(string _marca);
        void setModelo(string _modelo);
        void setAno(int _ano);
        void setPrecoDiario(float _precoDiario);
        string getPlaca();
        string getMarca();
        string getModelo();
        int getAno();
        float getPrecoDiario();
        string toString();
        ~Veiculo();
};

#endif // VEICULO_HPP
