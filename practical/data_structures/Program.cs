using System;
using System.Collections;

namespace DataStructures
{
    class Assigment2
    {

        public static void Main()
        {
            Graph graph = new Graph();
            Vertex airport1 = new Vertex("Cape Town");
            Vertex airport2 = new Vertex("PE");
            Vertex airport3 = new Vertex("Durbs");
            Vertex airport4 = new Vertex("Jo'burg (OR Tambo)");
            Vertex airport5 = new Vertex("Mauritius");
            Vertex airport6 = new Vertex("Harare");
            Vertex airport7 = new Vertex("Livingstone");
            Vertex airport8 = new Vertex("Victoria Falls");
            Vertex airport9 = new Vertex("Windhoek");

            graph.AddVertex(airport1);
            graph.AddVertex(airport2);
            graph.AddVertex(airport3);
            graph.AddVertex(airport4);
            graph.AddVertex(airport5);
            graph.AddVertex(airport6);
            graph.AddVertex(airport7);
            graph.AddVertex(airport8);
            graph.AddVertex(airport9);

            Edge flight1 = new Edge(airport1, airport4);
            Edge flight2 = new Edge(airport1, airport3);
            Edge flight3 = new Edge(airport1, airport2);
            Edge flight4 = new Edge(airport2, airport3);
            Edge flight5 = new Edge(airport2, airport4);
            Edge flight6 = new Edge(airport5, airport4);
            Edge flight7 = new Edge(airport6, airport4);
            Edge flight8 = new Edge(airport7, airport4);
            Edge flight9 = new Edge(airport8, airport4);
            Edge flight10 = new Edge(airport9, airport4);
            Edge flight11 = new Edge(airport3, airport4);

            graph.AddNewEdge(flight1);
            graph.AddNewEdge(flight2);
            graph.AddNewEdge(flight3);
            graph.AddNewEdge(flight4);
            graph.AddNewEdge(flight5);
            graph.AddNewEdge(flight6);
            graph.AddNewEdge(flight7);
            graph.AddNewEdge(flight8);
            graph.AddNewEdge(flight9);
            graph.AddNewEdge(flight10);
            graph.AddNewEdge(flight11);

            Console.WriteLine("There are " + graph.GetVertices().Count + " airports:");
            foreach (var vertex in graph.GetVertices())
            {
                Console.WriteLine("\t" + vertex.GetName());
            }

            Console.WriteLine("There are " + graph.GetEdges().Count + " direct flights:");
            foreach (var edge in graph.GetEdges())
            {
                Console.WriteLine("\t" + edge.GetPoint1().GetName() + " --> " + edge.GetPoint2().GetName());
            }

            Vertex airportToCheck = airport1;

            Console.WriteLine(airportToCheck.GetName() + " is connected with these airports:");
            foreach (var flight in graph.GetEdges())
            {
                if (flight.GetPoint1() == airportToCheck)
                {
                    Console.WriteLine("\t" + flight.GetPoint2().GetName());
                }
                else if (flight.GetPoint2() == airportToCheck)
                {
                    Console.WriteLine("\t" + flight.GetPoint1().GetName());
                }
            }

            airportToCheck = airport4;
            int flightCount = 0;
            foreach (var flight in graph.GetEdges()){
                if (flight.GetPoint1() == airportToCheck || flight.GetPoint2() == airportToCheck){
                    flightCount++;
                }
            }

            Console.WriteLine("There are " + flightCount + " direct flights from " + airportToCheck.GetName());
        }


    }

}