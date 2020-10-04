from flask import Flask, request, render_template, render_template_string

import pandas as pd

app = Flask(__name__)

@app.route('/')
def index():
    return render_template("index.html")


@app.route('/satellite')
def satellite():
    return render_template("satellite.html")

@app.route('/satellites')
def satellites():
    return render_template("satellites.html")


@app.route('/strela')
def strela():
    return render_template("strela.html")


@app.route('/starlink')
def starlink():
    return render_template("starlink2.html")


if __name__ == "__main__":
    app.run(debug=True)
