from flask import Flask, request, render_template, render_template_string


app = Flask(__name__)

@app.route('/')
def index():
    return render_template("index.html")


@app.route('/satellite')
def satellite():
    return render_template("satellite.html")

@app.route('/strela')
def strela():
    return render_template("strela.html")

@app.route('/satellites')
def satellites():
    return render_template("satellites.html")

if __name__ == "__main__":
    app.run(debug=True)
