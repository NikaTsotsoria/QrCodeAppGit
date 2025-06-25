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

### `/Interfaces`

- **`IQrCodeService.cs`**  
  Defines the **contract** for QR code-related operations, including generating and decoding QR codes. This interface abstracts QR code functionality, allowing for flexible swapping of the implementation or independent testing.

- **`IUrlShortenerService.cs`**  
  Declares methods for **URL shortening** services. This interface allows the app to shorten URLs before encoding them into QR codes, enabling more compact QR code content.

- **`IWatermarkService.cs`**  
  Specifies methods for **applying watermarks** to QR code images. This supports **customization** and **branding**, allowing QR codes to have logos, text, or other branding elements added to them.

---

### `/Models`

- **`QrCodeSettings.cs`**  
  Contains **configuration settings** for QR code generation, such as:
  - Size, colors, and error correction levels
  - Other customization options for the QR code

  This model centralizes all QR code-related settings, ensuring consistency across the app.

---

### `/Services`

- **`QrCodeService.cs`**  
  Implements the **`IQrCodeService`** interface using libraries like **QRCoder** and **ZXing.Net**. It handles the **core logic** of creating QR codes and decoding data from QR code images.

- **`UrlShortenerService.cs`**  
  Implements the **`IUrlShortenerService`** interface, providing **URL shortening** functionality. This service interacts with external APIs or custom logic to shorten URLs before encoding them into QR codes.

- **`WatermarkService.cs`**  
  Implements the **`IWatermarkService`** interface, adding **watermarks** or overlays to QR code images. This feature is useful for branding or additional visual customization of QR codes.

---

### `/Form`

- **`Form1.cs`**  
  The main **WinForms form** where users interact with the application. It contains UI elements like:
  - Text inputs, buttons for generating and decoding QR codes
  - Color pickers for customization
  - Picture boxes to display generated QR codes

  Event handlers in this file connect user actions (e.g., button clicks) to corresponding service calls.

- **`Form1.Designer.cs`**  
  An **auto-generated file** that defines the layout and UI controls of the form, such as:
  - Buttons, labels, text boxes, and image containers
  - Ensures the form’s controls are properly positioned and styled

