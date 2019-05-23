using System;

 

namespace gurkangokdemir

{


  class MainApp

  {


    static void Main()

    {

      // Create proxy and request a service

      Proxy proxy = new Proxy();

      proxy.Request();

 

      // Wait for user

      Console.ReadKey();

    }

  }

 

  abstract class Subject

  {

    public abstract void Request();

  }

 
  class RealSubject : Subject

  {

    public override void Request()

    {

      Console.WriteLine("Called RealSubject.Request()");

    }

  }

 


  class Proxy : Subject

  {

    private RealSubject _realSubject;

 

    public override void Request()

    {

      // Use 'lazy initialization'

      if (_realSubject == null)

      {

        _realSubject = new RealSubject();

      }

 

      _realSubject.Request();

    }

  }

}
 
