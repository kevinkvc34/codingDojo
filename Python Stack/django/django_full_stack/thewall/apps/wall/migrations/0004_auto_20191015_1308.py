# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2019-10-15 18:08
from __future__ import unicode_literals

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('wall', '0003_auto_20191015_1253'),
    ]

    operations = [
        migrations.AlterField(
            model_name='comment',
            name='Post',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, related_name='post_comments', to='wall.Post'),
        ),
        migrations.AlterField(
            model_name='comment',
            name='User',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, related_name='user_comments', to='login.Users'),
        ),
    ]
