# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2019-10-11 17:08
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('Main', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='show',
            name='description',
            field=models.TextField(default='this is a test desc'),
            preserve_default=False,
        ),
    ]
