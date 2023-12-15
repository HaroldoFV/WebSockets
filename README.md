# WebSockets Chat - Real-Time Communication Project
This project showcases a simple WebSocket-based chat application with multiple clients connected to a server. The server and client projects are named WebSocketsMultiple.API and WebSocketsMultiple.Client, respectively. The server is responsible for managing a chat room, while the client allows users to connect, input their name, send messages, and receive real-time updates. Both projects are written in C# using the .NET 8.

## Project Structure
## WebSocketsMultiple.API (Server)
The server project, WebSocketsMultiple.API, establishes a WebSocket connection and manages multiple clients in a chat room. It tracks connected clients and broadcasts messages to all connected users. The server listens on http://localhost:6969.

## WebSocketsMultiple.Client (Client)
The client project, WebSocketsMultiple.Client, allows users to connect to the server, input their name, send messages, and receive real-time updates.


## Requirements
Make sure to have .NET 8 installed to run both projects.

## How to Run
## WebSocketsMultiple.API (Server)
Open a terminal or command prompt.
Navigate to the WebSocketsMultiple.API directory.
cd WebSocketsMultiple.API
Run the command to start the server.
dotnet run

## WebSocketsMultiple.Client (Client)
Open a new terminal or command prompt.
Navigate to the WebSocketsMultiple.Client directory.
cd WebSocketsMultiple.Client
Run the command to start the client.
dotnet run

## Usage
After successfully running the server and client, real-time communication will be established. The client can send messages to the server, and all connected clients will receive messages instantly.

To exit the client, type "exit" and press Enter.

** Note: These projects (WebSockets.API and WebSockets.Client) are intended for basic WebSocket communication testing, where the client receives messages from the server in real-time. **

Feel free to open multiple instances of the client to simulate multiple users connecting to the chat room.

![image](https://github.com/HaroldoFV/WebSockets/assets/9435165/34e0c601-cd00-4f0b-9830-d656dbe8f7b6)
