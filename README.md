# LifeSure MVC Project

A comprehensive insurance company website built with ASP.NET MVC 5, featuring AI-powered content generation and social media integration.

## 🚀 Project Overview

LifeSure is a modern insurance company website that provides a complete content management system with AI integration for automatic content generation. The project includes both public-facing pages and an admin panel for content management.

## 🛠️ Technology Stack

- **Framework**: ASP.NET MVC 5
- **.NET Version**: 4.7.2
- **Database**: SQL Server with Entity Framework 6
- **Frontend**: HTML5, CSS3, JavaScript, Bootstrap 5
- **AI Integration**: 
  - ChatGPT API (RapidAPI) for FAQ generation
  - Hugging Face API for image generation
- **Social Media APIs**: 
  - Twitter API (RapidAPI)
  - LinkedIn API (RapidAPI)
- **Additional Libraries**: 
  - Newtonsoft.Json
  - jQuery
  - Font Awesome
  - Bootstrap Icons

## 📁 Project Structure

```
LifeSure_Mvc_Project/
├── LifeSure.WebApp/                 # Main web application
│   ├── Controllers/                 # MVC Controllers
│   │   ├── AdminController.cs      # Admin panel functionality
│   │   ├── HomeController.cs       # Public pages
│   │   └── LanguageController.cs   # Multi-language support
│   ├── Models/                     # Data models and view models
│   │   ├── DataModels/            # Entity Framework models
│   │   ├── CombinedUserViewModel.cs
│   │   ├── LinkedInUserViewModel.cs
│   │   └── TwitterUserViewModel.cs
│   ├── Services/                   # External API services
│   │   ├── LinkedInService.cs     # LinkedIn API integration
│   │   └── TwitterService.cs      # Twitter API integration
│   ├── Views/                      # Razor views
│   │   ├── Admin/                 # Admin panel views
│   │   ├── Home/                  # Public page views
│   │   └── Shared/                # Layout and shared views
│   ├── App_Data/                  # Application data
│   ├── App_GlobalResources/       # Localization resources
│   ├── Content/                   # CSS and static assets
│   ├── Scripts/                   # JavaScript files
│   └── LifeSure-1.0.0/           # Template assets
├── packages/                      # NuGet packages
└── LifeSure_Mvc_Project.sln      # Solution file
```

## 🎯 Key Features

### 🌐 Public Website
- **Multi-language Support**: English and Turkish
- **Responsive Design**: Mobile-friendly Bootstrap layout
- **Social Media Integration**: Real-time Twitter and LinkedIn follower counts
- **Dynamic Content**: All content managed through admin panel

### 🔧 Admin Panel
- **Complete CMS**: Manage all website content
- **AI-Powered Content Generation**:
  - ChatGPT integration for FAQ generation
  - Hugging Face integration for image generation
- **Social Media Management**: Twitter and LinkedIn integration
- **Multi-language Content Management**

### 🤖 AI Integrations

#### ChatGPT FAQ Generation
- **Endpoint**: `/Admin/GenerateChatGPTFAQs`
- **Features**:
  - Generate 3 FAQs from a single prompt
  - Automatic formatting and parsing
  - Bulk save functionality
  - Error handling with fallback content

#### Hugging Face Image Generation
- **Endpoint**: `/Admin/GenerateImage`
- **Features**:
  - Generate images from text descriptions
  - Automatic image preview
  - Base64 encoding for immediate display
  - Integration with service management

### 📱 Social Media Integration

#### Twitter Integration
- **Service**: `TwitterService.cs`
- **Features**:
  - Real-time follower count display
  - Username validation
  - Error handling with fallback values
- **API**: RapidAPI Twitter service

#### LinkedIn Integration
- **Service**: `LinkedInService.cs`
- **Features**:
  - Real-time follower count display
  - Profile identifier extraction
  - Direct profile linking
- **API**: RapidAPI LinkedIn scraper

## 🗄️ Database Schema

### Core Tables
- `Tbl_About` - Company information
- `Tbl_Contact` - Contact details
- `Tbl_Employee` - Team members
- `Tbl_FAQ` - Frequently asked questions
- `Tbl_Feature` - Company features
- `Tbl_Offer` - Service offers
- `Tbl_Service` - Services offered
- `Tbl_Testimonial` - Customer testimonials

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2019 or later
- SQL Server (LocalDB or full instance)
- .NET Framework 4.7.2

### Installation
1. Clone the repository
2. Open `LifeSure_Mvc_Project.sln` in Visual Studio
3. Update connection string in `Web.config` if needed
4. Restore NuGet packages
5. Build and run the project

### Configuration
- Update API keys in the following files:
  - `AdminController.cs`:
    - `YOUR-HUGGING-FACE-API-KEY` for image generation
    - `YOUR-RAPIDAPI-KEY` for ChatGPT FAQ generation
  - `TwitterService.cs`:
    - `YOUR-RAPIDAPI-KEY` for Twitter integration
  - `LinkedInService.cs`:
    - `YOUR-RAPIDAPI-KEY` for LinkedIn integration

## 📸 Screenshots
# Admin Panels & Features

<details>
<summary>▶️ Admin / Feature</summary>

![1](https://github.com/user-attachments/assets/280f42e7-5874-4457-849f-a84aa86e7c34)  
![2](https://github.com/user-attachments/assets/86ea619c-3b8c-4efe-a2dd-1796343ce0b2)  
![3](https://github.com/user-attachments/assets/d81efd59-7a77-4003-93fe-1f07ecb5d2d6)  

</details>

<details>
<summary>▶️ Admin / Offer</summary>

![1](https://github.com/user-attachments/assets/fd7e76f4-701a-41e6-80b7-7707ce5614c4)  
![2](https://github.com/user-attachments/assets/967a1101-261b-4b84-b684-01e6e5101264)  
![3](https://github.com/user-attachments/assets/e16b8936-55ea-4cbe-9c4f-af6a99fdfc17)  

</details>

<details>
<summary>▶️ Admin / About</summary>

![1](https://github.com/user-attachments/assets/ee280a15-dad2-4927-bd83-dbff5c472039)  
![2](https://github.com/user-attachments/assets/9e3f90ce-c51f-4810-98bb-0253ec2c9334)  
![3](https://github.com/user-attachments/assets/43bbaec0-80f9-4159-aff1-1bbd35896303)  

</details>

<details>
<summary>▶️ Admin / Service</summary>

![1](https://github.com/user-attachments/assets/0e753cbb-8759-435b-a2da-6d38657280e7)  
![2](https://github.com/user-attachments/assets/f64feaa6-fdbf-4868-935f-d2839d50c316)  
![3](https://github.com/user-attachments/assets/8e6e5427-c10d-46ac-8aa1-2cc0fa599c76)  

</details>

<details>
<summary>▶️ Admin / FAQs</summary>

![1](https://github.com/user-attachments/assets/8ff4d883-bb96-4fa7-b0e7-77ada05e3a0d)  
![Add FAQ](https://github.com/user-attachments/assets/ccddecbd-3d7e-4647-8640-2b5363c0f775)  
![Add FAQ 2](https://github.com/user-attachments/assets/53ac4f10-e248-4f4f-be7d-ffa56e7f366e)  
![Add FAQ 3](https://github.com/user-attachments/assets/124c5013-dea7-460c-977f-73286e42f3f7)  
![Add FAQ 4](https://github.com/user-attachments/assets/fece44b9-94b7-41ba-a970-18f0a4442def)  
![Edit FAQ](https://github.com/user-attachments/assets/15f550ca-8c36-4ed5-af39-c07839f2f93b)  

</details>

<details>
<summary>▶️ Admin / Employee</summary>

![1](https://github.com/user-attachments/assets/9cb5fb33-0504-4f51-95e5-9cff24493f9e)  
![2](https://github.com/user-attachments/assets/ff6aa1b6-4f10-49dd-8401-f216c5501682)  
![3](https://github.com/user-attachments/assets/681ab968-0d95-4c5c-8296-00baf7eca36a)  

</details>

<details>
<summary>▶️ Admin / Testimonial</summary>

![1](https://github.com/user-attachments/assets/16d9f644-8822-483b-9fd1-3c30a6b14e3b)  
![2](https://github.com/user-attachments/assets/6ff16dc9-4cba-47ce-810b-8e7b59665791)  
![3](https://github.com/user-attachments/assets/5d80e6a2-347f-42e5-8099-334a3cd88600)  

</details>

<details>
<summary>▶️ Admin / Contact</summary>

![1](https://github.com/user-attachments/assets/8f1e0d0e-311b-4bb7-bd1c-0c1317e46a01)  
![2](https://github.com/user-attachments/assets/7b4a562d-f450-4f43-8d1b-ddb029145733)  
![3](https://github.com/user-attachments/assets/605080f2-a9b0-4fc7-b708-37f06734a467)  

</details>

<details>
<summary>▶️ Home / Index</summary>

![Home](https://github.com/user-attachments/assets/419fb215-d5a7-4413-8c8c-4a505a35b803)

</details>

<details>
<summary>▶️ English</summary>

![English](https://github.com/user-attachments/assets/b9fa6f62-4999-404a-bc0f-d9024e510ddd)

</details>

<details>
<summary>▶️ Turkish</summary>

![Turkish](https://github.com/user-attachments/assets/191f3dc3-09f2-46e8-8142-42a749b32ea1)

</details>

<details>
<summary>▶️ LinkedIn & Twitter Followers</summary>

*(via RapidAPI)*  
✅ **@muratyucedag currently has the following followers count:**

- **LinkedIn:** (fetched dynamically)  
- **Twitter:** (fetched dynamically)

> _This section displays the live follower count for @muratyucedag, retrieved through the RapidAPI integration._

![Followers](https://github.com/user-attachments/assets/61a0c9c2-3e3d-4a00-aa2b-dc8bd130d58d)

</details>

### Public Website
- Home page with dynamic content
- About page with company information
- Services page with AI-generated images
- FAQ page with AI-generated content
- Contact page with real-time social media stats

### Admin Panel
- Dashboard overview
- FAQ management with AI generation
- Service management with image generation
- Social media integration
- Multi-language content management

## 🔧 API Endpoints

### Admin Endpoints
- `GET /Admin/Dashboard` - Admin dashboard
- `GET /Admin/Faq` - FAQ management
- `POST /Admin/GenerateChatGPTFAQs` - AI FAQ generation
- `POST /Admin/GenerateImage` - AI image generation
- `GET /Admin/Service` - Service management
- `GET /Admin/About` - About content management
- `GET /Admin/Contact` - Contact management
- `GET /Admin/Employee` - Team management
- `GET /Admin/Testimonial` - Testimonial management

### Public Endpoints
- `GET /` - Home page
- `GET /Home/About` - About page
- `GET /Home/Service` - Services page
- `GET /Home/FAQ` - FAQ page
- `GET /Home/Contact` - Contact page

## 🌍 Localization

The project supports multiple languages through resource files:
- `App_GlobalResources/SharedResource.resx` (English)
- `App_GlobalResources/SharedResource.tr.resx` (Turkish)

Language switching is handled by `LanguageController.cs`.

## 🔒 Security Features

- Admin panel authentication
- API key management
- Input validation and sanitization
- Error handling with fallback mechanisms
- Secure database connections

## 📊 Performance Optimizations

- Entity Framework optimization
- Static asset bundling
- Image optimization
- Caching strategies
- Async/await patterns for API calls

## 🐛 Error Handling

- Comprehensive try-catch blocks
- API error fallbacks
- User-friendly error messages
- Debug logging for development
- Graceful degradation for external services
