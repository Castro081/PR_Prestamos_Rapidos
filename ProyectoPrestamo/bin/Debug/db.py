import sqlite3

def agregar_columna():
    try:
        # Conectar a la base de datos SQLite
        conexion = sqlite3.connect('DBPRESTAMO.db')  # Asegúrate de poner la ruta correcta de tu base de datos
        cursor = conexion.cursor()

        # Paso 1: Agregar la columna IdTipoMoneda a la tabla Ahorro (sin clave foránea)
        cursor.execute("ALTER TABLE Ahorro ADD COLUMN IdTipoMoneda INTEGER;")
        print("Columna IdTipoMoneda agregada exitosamente a la tabla Ahorro.")

        # Commit de los cambios
        conexion.commit()

    except sqlite3.Error as e:
        print(f"Error al realizar las operaciones en la base de datos: {e}")
    finally:
        # Cerrar la conexión a la base de datos
        if conexion:
            conexion.close()

# Llamada a la función
agregar_columna()

