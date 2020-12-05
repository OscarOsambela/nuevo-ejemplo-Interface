using System;

interface INotificacion{
  void mostrarNotificacion();
  string mostrarFecha();
}

class MainClass {
  public static void Main (string[] args) {
      Notificacion m = new Notificacion("Como estás?", "Oscar", "3/12/2020");  
      m.mostrarNotificacion();
  }
}

class Notificacion:INotificacion{
  private string enviadoPor;
  private string mensaje;
  private string fecha;

  public Notificacion(string enviadoPor_, string mensaje_, string fecha_){
    this.enviadoPor = enviadoPor_;
    this.mensaje = mensaje_;
    this.fecha = fecha_;
  }
  public void mostrarNotificacion(){
    Console.WriteLine("El mensaje {0}, fue enviado por {1} el día {2}", enviadoPor, mensaje, fecha);
  }
  public string mostrarFecha(){
    return fecha;
  }
}


