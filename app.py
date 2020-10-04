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
    df = pd.read_excel('data-preprocessing/UCS-Satellite-Database-4-1-2020.xls')
    col1 = df['Name of Satellite, Alternate Names'].tolist()
    col2 = df['Country of Operator/Owner'].tolist()
    col3 = df['Operator/Owner'].tolist()
    col4 = df['Users'].tolist()
    col5 = df['Purpose'].tolist()
    return render_template("satellites.html", col1=col1, col2=col2, col3=col3, col4=col4,  col5=col5, len1=len(col1))


@app.route('/strela')
def strela():
    return render_template("strela.html")


@app.route('/starlink')
def starlink():
    return render_template("starlink2.html")

@app.route('/yahsat')
def yahsat():
    return render_template("yahsat.html")

@app.route('/microstat')
def microstat():
    return render_template("microstat.html")

@app.route('/aerocue')
def aerocue():
    return render_template("aerocue.html")

@app.route('/directv')
def directv():
    return render_template("directv.html")

@app.route('/navstar')
def navstar():
    return render_template("navstar.html")


if __name__ == "__main__":
    app.run(debug=True)
