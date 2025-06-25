# 📷 QR Code Generator Application

A **C# WinForms application** for generating and managing QR codes. This app allows you to create customized QR codes, decode them from images, and personalize their appearance with a user-friendly interface.

---

## ✨ Features

- 🔳 **QR Code Generation**  
  Create QR codes from text, URLs, and more.

- 🎨 **Customization Options**  
  Change:
  - Foreground and background colors  
  - Image size and resolution  
  - Error correction levels

- 🖼️ **Image Decoding**  
  Load and decode QR codes from image files (e.g., `.png`, `.jpg`).

- 🧭 **User-Friendly Interface**  
  Clean and responsive **WinForms UI** for smooth usage.

---

## 🧰 Libraries Used

- **[QRCoder (v1.6.0)](https://github.com/codebude/QRCoder)**  
  Pure C# QR code generation library.

- **[ZXing.Net (v0.16.10)](https://github.com/micjahn/ZXing.Net)**  
  For decoding QR codes and barcodes.

- **Microsoft.VisualBasic (v10.3.0)**  
  Used for helper functions and backward compatibility.

---
## 🧱 Project Structure

### `/Models`
Defines the **data structures** and **core business logic** of the application. This layer is responsible for holding essential information required for QR code generation, such as:

- The text or URL to encode  
- Configuration options (e.g., size, color, error correction level)

The **Models** layer encapsulates the primary data that drives the app's functionality, keeping everything organized and consistent.

---

### `/Form`
Builds the **WinForms user interface** where users interact with the app. This layer includes:

- Forms and controls for user input (e.g., text fields, color pickers)  
- UI elements to customize QR code appearance (e.g., size, colors)  
- Displaying the generated QR code image  

The **Form** also handle user interactions, such as button clicks, to trigger actions like QR code generation or decoding.

---

### `/Interfaces`
Defines **contracts** and **abstractions** for services like QR code generation and decoding. By using interfaces, the application ensures that components depend on abstract definitions rather than concrete implementations, promoting:

- **Modularity**: Components can be swapped or updated easily  
- **Maintainability**: Interfaces simplify testing and make code more flexible  

For example, an interface might declare methods for QR code generation without locking the app into a specific library or implementation.

---

### `/Services`
Contains the **core business logic** for QR code generation and decoding. This layer handles:

- QR code creation using libraries like **QRCoder**  
- QR code decoding using **ZXing.Net**

The **Services** take input from the **Views**, process it with the **Models**, and return results (e.g., QR code images) to be displayed in the UI.

---

By following this structure, the app maintains a **separation of concerns**, making the code easier to manage, extend, and maintain.
