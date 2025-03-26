# aps6
Supervised Practical Activities Project (APS) for the Computer Science program, submitted as part of the semester grade for the 6th semester in 2024.

<h2>🌱 About the Project</h2> 
This project implements a **facial recognition-based authentication system** designed to manage access to a sensitive database containing information about agricultural properties under investigation for the use of prohibited pesticides. The system ensures secure and restricted access based on user roles, leveraging biometric technology for enhanced security.
Key features:

Facial recognition authentication using the FaceAiSharp library.

Three access levels: Public, Directorate, and Minister, each with varying data visibility.

SQLite database for storing user credentials and investigation data.

Windows Forms interface for a user-friendly experience.

<h2>How It Works</h2> 
The system operates in three main stages: 1. **Login**: Users enter their CPF (Brazilian ID) and undergo facial recognition. 2. **Authentication**: The system compares the captured face with the stored image using cosine similarity (threshold ≥ 0.6 for approval). 3. **Data Access**: Based on the user's role, the system displays classified information (Low, Medium, or High confidentiality).
Ministers can register new users, while other roles have limited access.

<h2>🗂️ Project Structure</h2> 
    aps6/ <br>
    ├── database/ <br>
    │ └── CNPAdb.db # SQLite database (investigations + users) <br>
    ├── resources/ <br>
    │ └── imagens/ # Stores user facial images (CPF.jpg) <br>
    ├── CNPA/ <br>
    │ ├── AcessarBanco.cs # Database operations (SQLite) <br>
    │ ├── Cadastro.cs # User registration logic <br>
    │ ├── Informacoes.cs # Displays data based on access level <br>
    │ ├── Login.cs # Handles facial authentication <br>
    │ ├── Reconhecimento.cs # Facial recognition logic (FaceAiSharp) <br>
    │ └── Program.cs # Entry point └── packages/ # NuGet dependencies (FaceAiSharp, OpenCvSharp4, etc.) 

<h2>🚀 Getting Started</h2> 
**Prerequisites**: - Windows 10+ - .NET 6.0+ - Camera (720p minimum resolution)
Steps:

Clone the repository.

Restore NuGet packages (FaceAiSharp, OpenCvSharp4, Microsoft.Data.Sqlite).

Run the project in Visual Studio.

<h3>Try it:</h3> 
1. Log in with a registered CPF (e.g., `12345678900`). 
2. Allow camera access for facial recognition. 
3. If the similarity score is ≥ 0.6, access is granted. 

<h2>🤝 Contributors</h2> 
I extend my deepest gratitude to my teammates who dedicated their efforts to make this project a reality. I am grateful to Leonardo, Nicolas, and Kaiky for their collaboration in the meticulous research and conceptualization of the methodologies and technical apparatus used in this implementation. Special thanks to my dear friend and brother Diego, who brilliantly spearheaded the collaborative development process of this application.