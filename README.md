<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <h1>Desarrollo de Aplicación de Escritorio para la Gestión de Catálogo de Artículos</h1>

  <h2>Descripción del Proyecto</h2>
  <p>Desarrollamos en equipo una aplicación de escritorio utilizando C#, .NET Framework, ADO.NET y WinForms para la gestión de artículos de un catálogo de comercio. La aplicación está diseñada para ser genérica y aplicable a cualquier tipo de comercio. La información cargada en la aplicación será consumida desde distintos servicios para ser mostrada en webs, e-commerces, apps móviles, revistas, etc. Este uso es parte del contexto en el cual se utilizará la aplicación.</p>

  <h2>Características Principales</h2>
  <ul>
      <li>Listado de artículos.</li>
      <li>Búsqueda de artículos por distintos criterios.</li>
      <li>Agregar artículos.</li>
      <li>Modificar artículos.</li>
      <li>Eliminar artículos.</li>
      <li>Ver detalle de un artículo.</li>
  </ul>

  <p>La información se persiste en una base de datos existente. Los datos mínimos que debe tener un artículo incluyen:</p>
  <ul>
      <li>Código de artículo.</li>
      <li>Nombre.</li>
      <li>Descripción.</li>
      <li>Marca (seleccionable de una lista desplegable).</li>
      <li>Categoría (seleccionable de una lista desplegable).</li>
      <li>Imagen.</li>
      <li>Precio.</li>
  </ul>

  <p>El programa permite administrar las Marcas y Categorías disponibles, y cada producto puede tener una o más imágenes sin un límite establecido.</p>

  <h2>Etapas del Proyecto</h2>
  <h3>Etapa 1: Modelo y Navegación</h3>
  <ul>
      <li>Construcción de las clases necesarias para el modelo de la aplicación.</li>
      <li>Desarrollo de las ventanas y su navegación.</li>
  </ul>

  <h3>Etapa 2: Interacción con la Base de Datos y Validaciones</h3>
  <ul>
      <li>Implementación de la interacción con la base de datos utilizando ADO.NET.</li>
      <li>Validaciones correspondientes para asegurar la funcionalidad de la aplicación.</li>
  </ul>

  <h2>Aspectos Técnicos</h2>
  <ul>
      <li><strong>Lenguajes y Tecnologías:</strong>
          <ul>
              <li>C# para la lógica del programa.</li>
              <li>.NET Framework para la estructura de la aplicación.</li>
              <li>ADO.NET para la interacción con la base de datos.</li>
              <li>WinForms para la interfaz de usuario.</li>
          </ul>
      </li>
      <li><strong>Persistencia de Datos:</strong>
          <ul>
              <li>Uso de una base de datos existente para almacenar la información de los artículos.</li>
          </ul>
      </li>
  </ul>

  <h2>Repositorio del Proyecto</h2>
  <p><a href="https://github.com/aruuleon/tp-winform-equipo-15" target="_blank">GitHub - Desarrollo de equipo</a></p>

  <p>Este proyecto no solo mejoró nuestras habilidades en desarrollo de aplicaciones de escritorio y gestión de bases de datos, sino que también nos permitió aplicar prácticas efectivas de diseño y organización de código, asegurando una aplicación escalable y mantenible.</p>
</body>
</html>
